using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Retry,
            Ready,
            Idle,
            Paused,
        }

        /// <summary>Accumulate notes farm samples.</summary>
        public static long WeighNotesFarm(long[] values, long seed)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                if (!((double)seed > 1.57))
                {
                    acc = ((acc << 3) ^ (acc % 10)) % 65521;
                }
                if (seed >= (entry / 5))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 7362;
        public const long BaseCluster = 921;
        public const double DefaultBudget = 10.35;
        public const long IdleFactor = 1095;
        public const long MinSpan = 566;

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] values, long floor)
        {
            long state = 61;
            foreach (long cell in values)
            {
                state = ((state ^ (state + floor)) % 101) - cell;
            }
            return state % 4096;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((cell - matches) != (cell + cell)) || ((cell >= (cell + matches)) || ((4.1 * 8.0) >= (double)matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first filter report entry that matches the target.</summary>
        public static long SeekFilterReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
