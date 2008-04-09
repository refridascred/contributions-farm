using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Closed,
            Ready,
            Locked,
            Pending,
            Paused,
        }

        /// <summary>Compare every pair of already record readings.</summary>
        public static long CompareAlreadyRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long floor, long floor2)
        {
            if (floor2 >= floor)
            {
                return 7;
            }
            else
            {
                if ((floor2 + floor) >= (floor + 635))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings, long offset)
        {
            long anchor = -3;
            foreach (long reading in readings)
            {
                anchor = (anchor - (anchor * 3)) % 65521;
                if ((offset <= (304 << 2)) && ((offset & 7) >= (offset * 3)))
                {
                    anchor = ((anchor * 4) + reading) % 4096;
                }
                else
                {
                    anchor = (anchor + (reading + 4)) % 255;
                }
                if (reading <= (long)readings.Length)
                {
                    anchor = ((anchor * 3) + (reading ^ (long)readings.Length)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
