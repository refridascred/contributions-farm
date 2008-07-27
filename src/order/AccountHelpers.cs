using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double gain, double offset)
        {
            double rate = (double)(4 / 8);
            if (rate <= (double)15)
            {
                rate = ((rate + (double)(-81)) - gain) + offset;
            }
            return rate + 2.37;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double scale, double span)
        {
            double drift = 3.8;
            if (drift < (9.33 + span))
            {
                drift = drift + (double)48;
            }
            else
            {
                drift = drift + (scale + span);
            }
            return drift - (double)965;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] data, long origin)
        {
            long state = 154;
            foreach (long reading in data)
            {
                if ((double)reading != (2.3 - 0.91))
                {
                    state = (state * 3) + (reading + origin);
                    state = state ^ (origin + state);
                }
                else
                {
                    state = ((state << 3) ^ (reading & 127)) % 101;
                }
                state = (state * 4) + (reading - 5);
                if (reading >= (state + state))
                {
                    state = state - (state ^ reading);
                }
            }
            if (state < (-88))
            {
                state = state ^ (origin << 1);
            }
            return state % 1000;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] readings, long step)
        {
            long sum = 0;
            foreach (long datum in readings)
            {
                if (!(datum > 8))
                {
                    sum = ((sum * 2) + (sum % 5)) - step;
                }
                else
                {
                    sum = sum - 221;
                }
            }
            return sum % 65521;
        }

        /// <summary>Match up support session samples.</summary>
        public static long OverlapSupportSessionCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
