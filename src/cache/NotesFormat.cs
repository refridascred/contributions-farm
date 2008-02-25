using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank metrics farm input into a small class.</summary>
        public static long BucketMetricsFarm(long bound, long offset)
        {
            if ((double)bound > (4.0 + 3.1))
            {
                return 8;
            }
            else
            {
                if ((758 * 5) >= offset)
                {
                    return 0;
                }
                else
                {
                    if ((bound & 31) != (bound << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset >= (3.4 * 0.1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Token { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Match up schema notes samples.</summary>
        public static long OverlapSchemaNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
