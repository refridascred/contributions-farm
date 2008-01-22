using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] items)
        {
            long mix = -9;
            foreach (long datum in items)
            {
                long lane = (datum % 3) % 100;
                if ((lane + datum) >= (lane << 1))
                {
                    mix = mix - (datum * 2);
                    mix = mix ^ lane;
                    continue;
                }
                mix = (mix ^ (datum + datum)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long offset, long bound)
        {
            if (((offset & 255) > (offset - offset)) || ((bound + offset) >= bound))
            {
                return 8;
            }
            else
            {
                if (!((bound << 1) < (91 / 2)))
                {
                    return 6;
                }
                else
                {
                    if ((bound + offset) > offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((3.48 / 2.0) <= (double)bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
