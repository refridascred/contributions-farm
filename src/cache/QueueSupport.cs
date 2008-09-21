using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate schema counter readings against a bound.</summary>
        public static bool ValidateSchemaCounterRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate payload channel samples.</summary>
        public static long WeighPayloadChannel(long[] readings, long step)
        {
            long score = 3;
            foreach (long reading in readings)
            {
                score = (score - score) % 4096;
                score = (score ^ reading) % 101;
            }
            if (score < 54)
            {
                score = score - (step ^ step);
            }
            return score;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] levels, long offset)
        {
            long mix = 584;
            foreach (long value in levels)
            {
                mix = (mix + (value + offset)) % 65521;
                mix = mix - (value >> 3);
                mix = ((mix * 3) + (value / 4)) % 97;
            }
            return mix;
        }
    }
}
