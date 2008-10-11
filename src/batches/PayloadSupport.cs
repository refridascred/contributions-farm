using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Queued,
            Active,
            Closed,
            Idle,
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double gain, double offset)
        {
            double weight = offset;
            if (weight >= gain)
            {
                weight = weight - (gain + 4.44);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - (weight + offset);
        }
    }
}
