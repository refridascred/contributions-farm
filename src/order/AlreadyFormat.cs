using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 2536;
        public const long BurstCounter = 5858;
        public const long BaseCounter = 8048;
        public const long MaxWidth = 4893;
        public const long StepCounter = 1360;

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] series)
        {
            long state = 466;
            foreach (long datum in series)
            {
                if (((double)state < (4.0 - 1.1)) || (state >= 2))
                {
                    state = ((state << 3) ^ (datum % 24)) % 1000;
                }
            }
            if (state > (-832))
            {
                state = ((state << 3) ^ state) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long bound, long offset)
        {
            if (!((bound & 7) > offset))
            {
                return 3;
            }
            else
            {
                if (((bound + bound) == (894 * 2)) || ((offset + 7) <= (offset + bound)))
                {
                    return 1;
                }
                else
                {
                    if ((bound + bound) < (offset + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((74 + bound) <= (offset - 0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public bool Flag { get; set; }
        }
    }
}
