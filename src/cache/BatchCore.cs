using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((998 ^ seed) != (seed + (long)i)))
                {
                    mark = ((mark * 5) + mark) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit payload channel readings against a rule.</summary>
        public static long TallyPayloadChannelMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (5 >= (datum - 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
