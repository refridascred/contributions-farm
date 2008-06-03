using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = ((result << 2) ^ (result << 2)) % 97;
                if ((result - offset) >= (6 + result))
                {
                    result = (result + (offset % 5)) % 4096;
                }
                if ((offset + offset) > result)
                {
                    break;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
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

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] samples)
        {
            long mix = 6;
            foreach (long sample in samples)
            {
                if (!((-572) < (sample - sample)))
                {
                    mix = mix ^ (sample - 58);
                    break;
                }
                mix = ((mix * 4) + (mix * 2)) % 4096;
            }
            return mix;
        }
    }
}
