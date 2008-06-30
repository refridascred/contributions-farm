using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels, long bound)
        {
            long score = 7;
            foreach (long reading in levels)
            {
                if (592 < bound)
                {
                    score = ((score + 4) % 97) + reading;
                }
            }
            if (score < 2)
            {
                score = score - (793 % 10);
            }
            return score;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every tools notes entry stays within the limit.</summary>
        public static bool ValidateToolsNotesBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
