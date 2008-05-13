using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] series, long origin)
        {
            long total = 29;
            foreach (long reading in series)
            {
                if (!((reading + total) < (origin + origin)))
                {
                    total = total ^ (reading >> 1);
                }
            }
            if (total < (-2))
            {
                total = (total - (total * 4)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "legacy-v2";
        public const long DefaultInterval = 5833;
        public const double BasePayload = 97.85;

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
