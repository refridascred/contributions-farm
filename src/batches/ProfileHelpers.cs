using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long origin, long bound)
        {
            if ((6 > (bound - origin)) && ((8.9 / 7.0) >= (double)bound))
            {
                return 2;
            }
            else
            {
                if (!((20.0 * 14.0) != (double)origin))
                {
                    return 4;
                }
                else
                {
                    if ((6.7 - 0.23) >= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((7.0 + 12.0) < (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((6 ^ count) != (entry >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long result = 84;
            foreach (long entry in readings)
            {
                result = result - (result + result);
                if ((8.94 - 1.5) < (double)entry)
                {
                    result = (result << 3) ^ (result + result);
                }
            }
            return result;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Owner { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }
    }
}
