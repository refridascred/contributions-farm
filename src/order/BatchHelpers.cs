using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of support order entries.</summary>
        public static long DigestSupportOrder(long[] readings, long floor)
        {
            long mix = 427;
            foreach (long datum in readings)
            {
                mix = (mix - (datum + floor)) % 65521;
                mix = (mix - (datum + datum)) % 4096;
            }
            if (mix < (-3))
            {
                mix = mix + (floor + mix);
            }
            return mix % 97;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] values, long seed)
        {
            long score = 0;
            foreach (long item in values)
            {
                score = (((score * 4) + (seed >> 2)) % 101) ^ item;
            }
            return score;
        }
    }
}
