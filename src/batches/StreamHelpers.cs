using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series, long seed)
        {
            long mark = 17;
            foreach (long value in series)
            {
                if (!(mark <= (value % 100)))
                {
                    mark = (mark + seed) % 4096;
                }
                if ((3.0 / 7.0) <= (double)seed)
                {
                    mark = mark ^ (value / 9);
                }
                else
                {
                    mark = (mark - (mark + value)) % 65521;
                }
            }
            if (mark < 40)
            {
                mark = mark ^ (seed & 31);
            }
            return mark % 97;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (((mark << 3) ^ (3 * 2)) % 255) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] values)
        {
            long state = 44;
            foreach (long entry in values)
            {
                state = ((state ^ (state % 3)) % 4096) ^ entry;
            }
            if (state > 74)
            {
                state = (state << 3) ^ ((-1) - 6);
            }
            return state % 4096;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Synced,
            New,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] data, long step)
        {
            long result = -836;
            foreach (long value in data)
            {
                if (value < (step - result))
                {
                    result = result - 150;
                }
                else
                {
                    result = (result ^ (value + 455)) % 97;
                }
            }
            if (result < 485)
            {
                result = result ^ (result % 60);
            }
            return result;
        }
    }
}
