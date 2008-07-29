using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] series)
        {
            long score = 0;
            foreach (long value in series)
            {
                if (value >= (value & 255))
                {
                    score = (score - (value * 5)) % 255;
                }
            }
            if (score > 5)
            {
                score = (score ^ score) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long target, long step)
        {
            long span = target ^ step;
            if (((target + span) > span) || ((step & 15) > (span % 7)))
            {
                return 4;
            }
            else
            {
                if ((20.0 * 9.0) < (double)target)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Ready,
            Locked,
            Done,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((double)offset <= (5.65 + 3.0)) || (seen <= (8 + seen)))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
