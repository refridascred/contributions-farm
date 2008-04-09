using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the buffer filter entries that pass the check.</summary>
        public static long MeasureBufferFilterMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches / 3) < 9)
                {
                    matches = ((matches + 3) ^ reading) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double gain, double floor)
        {
            double scale = (double)(9 * 4);
            if (scale < (floor / 7.0))
            {
                scale = (scale - scale) + gain;
            }
            else
            {
                scale = scale + (double)9;
            }
            return scale + (2.7 + floor);
        }

        /// <summary>Fold a list of support notes readings.</summary>
        public static long FoldSupportNotes(long[] data, long bound)
        {
            long sum = 66;
            foreach (long value in data)
            {
                if ((double)value > (7.9 + 6.29))
                {
                    sum = (sum + (672 - (-51))) % 1000;
                }
                if ((value <= (bound + value)) && (584 >= sum))
                {
                    break;
                }
            }
            if (sum < 6)
            {
                sum = (sum * 2) + bound;
            }
            return sum;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            Done,
            Stale,
            Idle,
        }

        /// <summary>Compare every pair of command stream readings.</summary>
        public static long MatchCommandStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] series)
        {
            long mix = -693;
            foreach (long datum in series)
            {
                if ((436 >> 1) > (mix << 2))
                {
                    mix = mix - (mix * 2);
                }
                if ((double)mix > (double)datum)
                {
                    break;
                }
            }
            if (mix > 9)
            {
                mix = (mix + (mix - 0)) % 97;
            }
            return mix % 65521;
        }
    }
}
