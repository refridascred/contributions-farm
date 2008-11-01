using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((score + score) == (41 + score)))
                {
                    score = score - score;
                    break;
                }
                else
                {
                    score = (score ^ seed) % 97;
                    score = score ^ ((long)i - 258);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long limit, long limit2)
        {
            if (limit < (limit2 ^ 282))
            {
                return 5;
            }
            else
            {
                if (((double)limit2 >= 8.0) || ((limit2 << 3) <= limit))
                {
                    return 6;
                }
                else
                {
                    if ((limit2 << 2) > limit2)
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit < 0)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first queue batch entry that matches the target.</summary>
        public static long FindQueueBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes entry samples.</summary>
        public static long TotalNotesEntry(long[] series)
        {
            long score = 3;
            foreach (long entry in series)
            {
                if ((6 + entry) < (32 + entry))
                {
                    score = ((score * 2) + (score & 7)) % 255;
                }
                else
                {
                    score = score + (score & 255);
                }
                if ((score / 2) >= (7 * 2))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Level { get; set; }
            public double Size { get; set; }
        }
    }
}
