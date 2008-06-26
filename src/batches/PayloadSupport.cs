using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank contributi route input into a small class.</summary>
        public static long ClassifyContributiRoute(long step, long limit)
        {
            long slot = step ^ limit;
            if (!((slot >> 4) != (limit + step)))
            {
                return 3;
            }
            else
            {
                if ((limit + slot) <= step)
                {
                    return 2;
                }
                else
                {
                    if (!((limit - step) == (step + slot)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Ready,
            New,
        }
    }
}
