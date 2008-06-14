using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Active,
            Closed,
        }

        /// <summary>Classify a schema session pair into a bucket.</summary>
        public static long ClassifySchemaSession(long limit, long seed)
        {
            if (!(limit > seed))
            {
                return 5;
            }
            else
            {
                if ((seed / 2) <= ((-794) / 3))
                {
                    return 2;
                }
                else
                {
                    if ((7 <= (seed + limit)) && ((limit >> 1) >= (limit - seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit <= (limit + limit)) || ((double)seed < 8.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)tally <= (10.0 - 5.35))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double gain, double bias)
        {
            double rate = bias;
            if (rate > (double)260)
            {
                rate = rate - gain;
            }
            else
            {
                rate = rate + (double)31;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (rate * 2.32)) + (double)(long)i;
            }
            return rate + (rate + 6.94);
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
