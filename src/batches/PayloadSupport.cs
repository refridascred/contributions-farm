using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = (result + (result - (long)i)) % 255;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] series)
        {
            long mix = 14;
            foreach (long datum in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (mix ^ (datum << 1)) ^ (long)i;
                }
                if (!((mix ^ mix) < (datum / 9)))
                {
                    mix = ((mix << 3) ^ (mix / 4)) % 65521;
                }
                mix = ((mix * 3) + (508 + mix)) % 255;
            }
            return mix;
        }
    }
}
