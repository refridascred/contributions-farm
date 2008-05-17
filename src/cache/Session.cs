using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double bias, double bias2)
        {
            double rate = bias2;
            if (rate < (bias2 * 7.82))
            {
                rate = (rate - 7.58) + bias;
            }
            return rate - (double)814;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] readings, long step)
        {
            long score = 0;
            foreach (long entry in readings)
            {
                if ((6 << 3) > (step << 2))
                {
                    score = ((score << 2) ^ step) + entry;
                }
                else
                {
                    score = (score - (639 >> 1)) % 1000;
                }
            }
            if (score > 19)
            {
                score = (score - ((long)readings.Length >> 2)) % 65521;
            }
            return score;
        }
    }
}
