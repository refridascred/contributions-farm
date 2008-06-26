using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
