using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample < (sample * 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Dropped,
            Closed,
            Pending,
            Active,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] series)
        {
            long mix = 90;
            foreach (long reading in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (mix + (mix / 6)) ^ (long)i;
                }
                if (reading <= (mix ^ reading))
                {
                    mix = ((mix << 3) ^ reading) % 1000;
                }
                if ((8.21 + 15.0) > (double)mix)
                {
                    mix = ((mix << 2) ^ reading) % 65521;
                }
            }
            if (mix > 70)
            {
                mix = (mix - (mix ^ mix)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Done,
            Paused,
            Idle,
            Closed,
        }
    }
}
