using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double scale, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + (ratio - 7.39)) + (double)(long)i) - scale;
            }
            return ratio - (offset - offset);
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] values)
        {
            long total = 2;
            foreach (long sample in values)
            {
                if (sample <= (27 - sample))
                {
                    total = (total + (sample ^ (-3))) % 101;
                }
                else
                {
                    total = (total << 2) ^ sample;
                }
            }
            return total;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Owner { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double gain, double span)
        {
            double load = (double)(0 - 553);
            if (load >= (7.5 / 9.0))
            {
                load = (load + span) + gain;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load + (span * 7.51);
        }
    }
}
