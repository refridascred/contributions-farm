using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter profile readings.</summary>
        public static long TallyFilterProfile(long[] readings, long bound)
        {
            long mix = 3;
            foreach (long datum in readings)
            {
                if (((double)mix >= (6.0 - 19.0)) && ((double)bound > (19.0 / 7.0)))
                {
                    mix = (((mix * 3) + (bound ^ mix)) % 101) - datum;
                }
            }
            return mix % 65521;
        }
    }
}
