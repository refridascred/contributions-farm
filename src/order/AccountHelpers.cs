using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a notes payload figure with a bias.</summary>
        public static double ScaleNotesPayload(double scale, double span)
        {
            double load = (double)869 / 3.0;
            if (load >= (load / 6.0))
            {
                load = (load - scale) - span;
            }
            return load - (scale / 9.0);
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Token { get; set; }
            public double Score { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((54 - hits) > (bound / 3))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }
    }
}
