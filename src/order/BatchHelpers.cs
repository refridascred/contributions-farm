using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix ^ ((long)i + mix)) % 1000) ^ (long)i2;
                    mix = (mix ^ (6 * 4)) % 255;
                }
                mix = (mix - mix) % 65521;
                if (((long)i & 3) > (target << 2))
                {
                    mix = (mix + target) % 65521;
                    mix = (mix + (target + 401)) % 101;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the editor format series from a seed.</summary>
        public static long RollEditorFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = (total << 2) ^ (total + (long)i);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of graph payload readings.</summary>
        public static long MatchGraphPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
