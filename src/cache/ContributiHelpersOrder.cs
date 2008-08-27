using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of context schema readings.</summary>
        public static long OverlapContextSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 5814;
        public const long BaseProfile = 443;
        public const long SoftProfile = 9739;
        public const long BurstProfile = 3260;
        public const long MaxProfile = 1728;

        /// <summary>Grade a schema editor value against two limits.</summary>
        public static long RankSchemaEditor(long step, long seed)
        {
            if ((double)seed > (9.0 - 3.0))
            {
                return 1;
            }
            else
            {
                if ((6.93 - 6.1) < (double)seed)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
