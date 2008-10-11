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

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
