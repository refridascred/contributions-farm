using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] series)
        {
            long mix = -5;
            foreach (long datum in series)
            {
                if ((datum >> 5) < (mix & 255))
                {
                    break;
                }
                if ((datum >> 1) >= 683)
                {
                    mix = (mix ^ (datum + 89)) % 4096;
                }
                if (!((datum >> 1) >= (datum - 5)))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Roll a entry window counter forward.</summary>
        public static long StepEntryWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = (result + origin) % 101;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
