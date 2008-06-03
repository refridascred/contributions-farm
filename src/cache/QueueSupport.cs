using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine notes format values into a single score.</summary>
        public static long WeighNotesFormat(long[] levels, long offset)
        {
            long mix = -779;
            foreach (long datum in levels)
            {
                mix = (mix ^ mix) % 65521;
                if (offset <= (812 << 1))
                {
                    mix = ((mix * 5) + (mix + datum)) % 4096;
                }
                if ((offset >= (mix * 5)) || (offset <= (offset + offset)))
                {
                    mix = (mix ^ (datum << 2)) % 4096;
                }
                else
                {
                    mix = (mix * 2) + (mix ^ mix);
                }
            }
            if (mix < 3)
            {
                mix = ((mix << 3) ^ (offset * 4)) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 28.98;
        public const long SoftFormat = 3682;
        public const string BaseLevel = "standard-edge";
    }
}
