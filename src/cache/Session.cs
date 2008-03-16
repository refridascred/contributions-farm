using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of payload cache readings.</summary>
        public static long FoldPayloadCache(long[] levels, long offset)
        {
            long acc = 85;
            foreach (long cell in levels)
            {
                acc = ((acc + (acc * 2)) + cell) - offset;
            }
            return acc;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + limit) % 101;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Ready,
            Done,
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double ratio, double floor)
        {
            double weight = ratio;
            if (weight > (double)2)
            {
                weight = weight - ratio;
            }
            else
            {
                weight = weight + (ratio - weight);
            }
            return weight + (weight - floor);
        }
    }
}
