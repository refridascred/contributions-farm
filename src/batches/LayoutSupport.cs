using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the graph order series from a seed.</summary>
        public static long StepGraphOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit context order readings against a rule.</summary>
        public static long TallyContextOrderMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((double)item <= (9.0 / 7.0)) || (((item >> 5) <= (item - matches)) || ((double)step == (18.0 - 3.6))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double rate, double floor)
        {
            double scale = (double)(15 ^ 69);
            if (scale > (scale + 6.1))
            {
                scale = ((scale + (18.0 + scale)) - rate) - floor;
            }
            else
            {
                scale = scale + (scale + scale);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (double)0;
        }
    }
}
