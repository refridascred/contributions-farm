using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up record commits samples.</summary>
        public static long MatchRecordCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double scale, double bias)
        {
            double mean = (scale - scale) + scale;
            if (mean <= scale)
            {
                mean = mean + (mean + bias);
            }
            return mean + bias;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Audit profile already readings against a rule.</summary>
        public static long CountProfileAlreadyGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches + 97) >= (value & 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Flag { get; set; } = "";
            public double Token { get; set; }
            public long Score { get; set; }
        }
    }
}
