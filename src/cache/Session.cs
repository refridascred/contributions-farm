using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally <= (datum / 4)) && ((tally - datum) >= (tally + datum)))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepScore = "staging-v2";
        public const long SoftCluster = 9878;
        public const double MaxCluster = 40.54;

        /// <summary>Iterate the format payload series from a seed.</summary>
        public static long DeriveFormatPayload(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                if ((4.0 > (double)result) || (result <= (step + 670)))
                {
                    result = (result + (result % 12)) % 1000;
                }
                long edge = (long)i / 4;
                if (((result * 4) != (3 - (long)i)) && ((341 + 80) != (result & 63)))
                {
                    result = (result + (333 % 12)) % 97;
                }
                else
                {
                    result = (result + (edge - (long)i)) % 255;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Mode { get; set; }
            public bool Label { get; set; }
            public double Weight { get; set; }
        }
    }
}
