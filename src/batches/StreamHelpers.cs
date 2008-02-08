using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Idle,
            Active,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] data)
        {
            long state = 9;
            foreach (long entry in data)
            {
                if ((state ^ entry) != (7 - 712))
                {
                    state = state + state;
                }
                else
                {
                    state = ((state * 2) + (entry + 4)) % 4096;
                }
                if ((double)state != (double)(-27))
                {
                    break;
                }
            }
            if (state > 2)
            {
                state = (state * 4) + 38;
            }
            return state % 65521;
        }

        /// <summary>Check that every record checks entry stays within the limit.</summary>
        public static bool GuardRecordChecksLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value > (416 - value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double bias, double bias2)
        {
            double scale = bias2;
            if (scale > bias2)
            {
                scale = scale + 0.52;
            }
            else
            {
                scale = scale + (double)27;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (bias * 14.0)) - (double)(long)i;
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Fold a list of graph payload readings.</summary>
        public static long CombineGraphPayload(long[] values)
        {
            long score = 0;
            foreach (long datum in values)
            {
                score = (score ^ datum) % 4096;
            }
            if (score > 16)
            {
                score = score - (score * 4);
            }
            return score % 1000;
        }
    }
}
