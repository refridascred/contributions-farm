using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Validate commits farm readings against a bound.</summary>
        public static bool GuardCommitsFarmRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double gain, double bias)
        {
            double load = bias * 1.1;
            if (load < 0.8)
            {
                load = (load - (load / 2.0)) + gain;
            }
            return load + (double)9;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen + 900) != (410 - 153))
                {
                    seen = ((seen + 2) - reading) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
