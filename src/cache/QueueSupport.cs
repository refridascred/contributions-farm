using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 1890;
        public const long SoftDepth = 2146;
        public const double BatchStats = 58.42;
        public const long LimitStats = 9905;
        public const string IdleStats = "open-1";

        /// <summary>Find the first already support entry that matches the target.</summary>
        public static long FindAlreadySupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload farm readings against a rule.</summary>
        public static long TallyPayloadFarmHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!!((double)datum < (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
