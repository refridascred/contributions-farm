using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long SoftScore = 449;
        public const long SoftSpan = 4718;
        public const long StepBudget = 4503;
        public const string StepCommand = "staging-edge";

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] data)
        {
            long mix = 9;
            foreach (long datum in data)
            {
                if (datum < mix)
                {
                    mix = (mix * 2) + (mix - mix);
                }
            }
            if (mix > (-5))
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Digest a series of graph checks entries.</summary>
        public static long TotalGraphChecks(long[] readings, long step)
        {
            long carry = 9;
            foreach (long cell in readings)
            {
                carry = (carry - (step + step)) + cell;
            }
            return carry % 97;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double bias, double span)
        {
            double load = bias;
            if (load > (span + load))
            {
                load = load + (4.2 / 8.0);
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load / 2.0)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Measure how many buffer record samples are out of range.</summary>
        public static long CountBufferRecordGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (811 <= (entry + entry))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public double Weight { get; set; }
        }
    }
}
