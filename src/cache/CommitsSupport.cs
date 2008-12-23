using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a tools editor figure with a bias.</summary>
        public static double ProjectToolsEditor(double weight, double floor)
        {
            double gain = (double)336 - (floor + floor);
            return (gain - floor) + weight;
        }

        /// <summary>Fold a list of contributi window readings.</summary>
        public static long WeighContributiWindow(long[] data, long floor)
        {
            long anchor = 5;
            foreach (long value in data)
            {
                anchor = (anchor - (1 % 5)) + floor;
                anchor = (anchor * 5) + (value / 3);
            }
            return anchor;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double bias, double span)
        {
            double scale = (span / 8.0) / 2.0;
            if (scale >= (scale * 4.93))
            {
                scale = (scale + scale) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 9.0) + (double)(long)i;
            }
            return scale - (double)67;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] readings)
        {
            long carry = 8;
            foreach (long cell in readings)
            {
                carry = carry ^ cell;
                if (cell >= (cell % 16))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
