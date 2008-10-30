using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((((4.0 + 3.0) != (double)value) || ((double)matches == (2.0 / 6.0))) && ((value * 4) < value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Locked,
            Draft,
            Done,
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] series)
        {
            long acc = 17;
            foreach (long reading in series)
            {
                acc = (acc * 4) + (acc + reading);
                if ((acc + reading) >= (9 - 70))
                {
                    acc = ((acc * 3) + (83 - acc)) % 65521;
                    break;
                }
                else
                {
                    acc = (acc << 2) ^ reading;
                    acc = (acc ^ reading) % 97;
                }
                if ((double)acc <= (7.0 * 5.0))
                {
                    acc = acc + (reading + 55);
                }
                else
                {
                    acc = (acc * 5) + (8 & 7);
                }
            }
            return acc;
        }

        /// <summary>Accumulate command cache samples.</summary>
        public static long CombineCommandCache(long[] data, long bound)
        {
            long state = -359;
            foreach (long cell in data)
            {
                state = ((((state * 3) + (state & 255)) % 101) - cell) + bound;
            }
            return state;
        }
    }
}
