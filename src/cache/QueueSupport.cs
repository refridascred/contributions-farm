using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Draft,
            Retry,
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
