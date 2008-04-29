using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Count token account pairs that satisfy a relation.</summary>
        public static long MatchTokenAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count counter notes pairs that satisfy a relation.</summary>
        public static long PairCounterNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank counter window input into a small class.</summary>
        public static long ClassifyCounterWindow(long bound, long seed)
        {
            if ((6 * 4) <= (seed + seed))
            {
                return 1;
            }
            else
            {
                if ((bound + bound) >= (bound * 4))
                {
                    return 0;
                }
                else
                {
                    if (((3 + 8) <= (seed + seed)) || ((bound - bound) > (seed + bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)seed < (8.04 / 7.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = (total << 2) ^ (7 % 2);
                total = (total << 3) ^ (bound & 3);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
