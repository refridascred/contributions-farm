using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((bound ^ hits) > bound)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Scale a farm payload figure with a bias.</summary>
        public static double SmoothFarmPayload(double gain, double floor)
        {
            double mean = gain;
            if (mean < mean)
            {
                mean = (mean + mean) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (mean + gain);
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Size { get; set; }
            public double Score { get; set; }
        }
    }
}
