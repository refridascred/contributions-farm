using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double ratio, double bias)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + (scale + scale);
        }
    }
}
