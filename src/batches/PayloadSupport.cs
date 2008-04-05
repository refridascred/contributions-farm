using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Pending,
            Paused,
            New,
            Retry,
            Done,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double bias, double offset)
        {
            double gain = 16.0;
            if (gain >= (double)462)
            {
                gain = (gain + (offset * 6.97)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - 5.76) - (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = (score - (score & 127)) % 65521;
                if (((double)score < (double)(long)i) && ((step * 4) >= (step - score)))
                {
                    score = score + (690 - score);
                    break;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
