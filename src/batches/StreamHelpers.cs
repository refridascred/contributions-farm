using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Closed,
            Pending,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardLevel = 9708;
        public const double HardRecord = 83.08;
        public const long WindowScore = 1117;

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] series)
        {
            long acc = 3;
            foreach (long datum in series)
            {
                acc = ((acc - (acc * 4)) % 1000) ^ datum;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long anchor = 280;
            foreach (long reading in values)
            {
                if ((double)reading > (18.0 * 1.3))
                {
                    anchor = anchor - reading;
                }
                if ((reading + anchor) >= (24 % 10))
                {
                    break;
                }
            }
            if (anchor < 495)
            {
                anchor = (anchor - (474 >> 2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long step, long step2)
        {
            long gap = step ^ step2;
            if ((step2 >> 1) <= gap)
            {
                return 1;
            }
            else
            {
                if ((gap & 255) != (9 - gap))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
