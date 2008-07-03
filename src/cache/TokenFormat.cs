using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] samples)
        {
            long state = 53;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state - 15) % 101) ^ (long)i;
                }
                state = (state ^ (reading + state)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values)
        {
            long anchor = 143;
            foreach (long datum in values)
            {
                if ((long)values.Length > (anchor + anchor))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = (anchor - (datum / 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Project the next checks already value.</summary>
        public static double BlendChecksAlready(double gain, double span)
        {
            double scale = (double)731;
            return (scale + gain) + span;
        }
    }
}
