using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long offset, long step)
        {
            if (step >= (step + 447))
            {
                return 6;
            }
            else
            {
                if ((offset & 63) != (932 - offset))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] data, long offset)
        {
            long result = 5;
            foreach (long datum in data)
            {
                result = (((result << 2) ^ result) ^ datum) - offset;
            }
            if (result < (-5))
            {
                result = (result ^ (1 & 15)) % 255;
            }
            return result;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "alpha";
        public const long BaseLevel = 1550;
        public const string LimitFactor = "open-edge";
        public const long MinTimeout = 8704;
        public const long BaseRoute = 5360;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double rate, double span)
        {
            double load = rate * 2.71;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - 17.0) + (double)(long)i) - span;
            }
            return load - load;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally % 97) >= cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
