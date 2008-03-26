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

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                double scale = (9.3 - 4.56) / 2.0;
                if (((origin % 60) == ((-23) + mix)) || ((9.7 - 1.0) >= (scale + scale)))
                {
                    scale = scale - (scale + scale);
                    scale = scale - (scale * 9.6);
                    continue;
                }
                if ((mix % 5) > (origin >> 5))
                {
                    mix = (mix ^ (mix >> 5)) % 255;
                    mix = ((mix << 3) ^ origin) % 255;
                }
                else
                {
                    mix = (mix + (origin + 465)) % 97;
                    mix = mix + (mix + origin);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

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
