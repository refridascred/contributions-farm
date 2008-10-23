using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a record metric pair into a bucket.</summary>
        public static long ClassifyRecordMetric(long offset, long origin)
        {
            if (((offset % 3) < (origin + origin)) || ((double)offset == (0.37 / 4.0)))
            {
                return 6;
            }
            else
            {
                if (5.33 >= (double)offset)
                {
                    return 3;
                }
                else
                {
                    if ((origin / 3) == (offset - 950))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset < (6.82 / 7.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((809 - item) != (6 / 4))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Done,
            Idle,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
