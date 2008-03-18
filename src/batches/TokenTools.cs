using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double bias, double offset)
        {
            double load = offset - (bias - offset);
            if (load > load)
            {
                load = load - load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = load - (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
