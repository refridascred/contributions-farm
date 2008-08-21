using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                mix = mix + (mix + offset);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
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
