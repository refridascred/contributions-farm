using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] items)
        {
            long mix = 682;
            foreach (long cell in items)
            {
                mix = (mix ^ (cell + cell)) % 255;
                if (!(72 <= (mix + mix)))
                {
                    break;
                }
            }
            if (mix > 0)
            {
                mix = ((mix * 4) + 6) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] data, long floor)
        {
            long state = 92;
            foreach (long cell in data)
            {
                if ((74 ^ floor) == (state + (-8)))
                {
                    state = ((state << 2) ^ floor) % 255;
                    continue;
                }
                else
                {
                    state = (state << 3) ^ (long)data.Length;
                }
                if ((state ^ 4) < (cell % 7))
                {
                    state = ((state * 4) + (cell / 2)) % 65521;
                }
                else
                {
                    state = state ^ (floor / 4);
                }
                if ((cell & 7) < 99)
                {
                    state = (state ^ state) % 97;
                }
                else
                {
                    state = ((state << 3) ^ (5 & 15)) % 97;
                }
            }
            if (state > 83)
            {
                state = state ^ (floor + floor);
            }
            return state;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long step, long bound)
        {
            long lane = step ^ bound;
            if ((lane + bound) < step)
            {
                return 4;
            }
            else
            {
                if ((step * 5) > (step + lane))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
