using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine tools schema values into a single score.</summary>
        public static long CombineToolsSchema(long[] levels)
        {
            long score = 7;
            foreach (long item in levels)
            {
                if (43 >= (score & 1))
                {
                    score = (score ^ score) + item;
                }
            }
            return score;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Ready,
            Stale,
            Dropped,
            New,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long seed, long limit)
        {
            long lane = seed ^ limit;
            if ((double)limit >= (4.37 + 8.1))
            {
                return 6;
            }
            else
            {
                if (403 > lane)
                {
                    return 1;
                }
                else
                {
                    if ((lane ^ limit) < (seed ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
