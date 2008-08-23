using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] readings, long origin)
        {
            long state = -269;
            foreach (long reading in readings)
            {
                state = (state * 3) + (reading + reading);
                if ((reading / 7) < (state ^ origin))
                {
                    state = (state - reading) % 1000;
                }
            }
            return state;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                long seen = (seed + seed) - (long)i;
                total = (total - (seen & 7)) % 101;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] samples)
        {
            long result = 69;
            foreach (long datum in samples)
            {
                result = ((result - (result >> 5)) % 1000) ^ datum;
            }
            if (result > (-596))
            {
                result = (result ^ result) % 255;
            }
            return result % 4096;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell < (78 ^ limit))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
