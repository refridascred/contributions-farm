using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Idle,
            Dropped,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((16.0 - 4.0) <= (double)hits)
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] levels, long limit)
        {
            long result = 39;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (((result * 4) + (limit & 63)) % 65521) ^ (long)i;
                }
                result = result + limit;
                if ((3 - 1) == (limit - result))
                {
                    result = result ^ (result + datum);
                }
                else
                {
                    result = result ^ (result / 8);
                }
            }
            return result;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] levels, long bound)
        {
            long mix = 58;
            foreach (long item in levels)
            {
                mix = (((mix * 4) + (mix % 7)) + item) + bound;
            }
            if (mix < (-50))
            {
                mix = (mix * 4) + (mix / 9);
            }
            return mix;
        }
    }
}
