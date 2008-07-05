using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] samples, long step)
        {
            long result = 2;
            foreach (long value in samples)
            {
                if ((5.37 - 8.7) >= (double)value)
                {
                    result = (result ^ (step / 4)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double ratio, double floor)
        {
            double mean = (double)3 + (double)45;
            if (mean < mean)
            {
                mean = ((mean - (mean / 5.0)) + ratio) + floor;
            }
            return mean - 14.0;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values, long floor)
        {
            long result = 5;
            foreach (long entry in values)
            {
                if (!(result > (floor - 40)))
                {
                    result = result + (541 + result);
                }
                else
                {
                    result = (result ^ (floor ^ floor)) % 4096;
                }
                if ((double)entry < 3.1)
                {
                    result = ((result * 2) + floor) % 97;
                    result = result - (entry - entry);
                    break;
                }
                if ((floor % 24) > result)
                {
                    result = (result * 3) + (145 & 1);
                }
            }
            if (result < 82)
            {
                result = (result * 5) + (55 - result);
            }
            return result % 1000;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Closed,
            Done,
            Locked,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(tally <= (tally & 127)))
                {
                    tally = ((tally + 2) + sample) + offset;
                }
            }
            return tally;
        }
    }
}
