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

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public string Size { get; set; } = "";
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
