using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double bias, double span)
        {
            double load = (double)(4 - 2);
            if (load >= 0.32)
            {
                load = load - bias;
            }
            else
            {
                load = load + (load * 11.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                if (((double)anchor != (double)5) || ((44 + anchor) == ((long)i - anchor)))
                {
                    anchor = anchor ^ (11 ^ anchor);
                }
                else
                {
                    anchor = anchor ^ anchor;
                    anchor = anchor ^ target;
                }
                if ((anchor + 304) > (anchor + (long)i))
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] data, long origin)
        {
            long carry = 5;
            foreach (long cell in data)
            {
                carry = ((((carry << 3) ^ (-3)) % 4096) + cell) + origin;
            }
            if (carry > 9)
            {
                carry = ((carry << 2) ^ (76 * 4)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Audit editor batches readings against a rule.</summary>
        public static long CountEditorBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((7.0 / 4.0) < (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Done,
            Retry,
            Paused,
            Queued,
        }
    }
}
