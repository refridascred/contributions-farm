using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate batches schema samples.</summary>
        public static long ScoreBatchesSchema(long[] series)
        {
            long acc = 8;
            foreach (long datum in series)
            {
                if (datum >= (acc ^ datum))
                {
                    acc = (acc * 4) + (datum & 255);
                }
                else
                {
                    acc = (acc ^ (-6)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every batch payload entry stays within the limit.</summary>
        public static bool GuardBatchPayloadBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
