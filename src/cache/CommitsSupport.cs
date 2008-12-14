using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of support checks entries.</summary>
        public static long TallySupportChecks(long[] values)
        {
            long mix = 93;
            foreach (long reading in values)
            {
                if ((reading & 255) > (mix + reading))
                {
                    mix = (mix - mix) % 4096;
                }
                if ((double)reading >= (5.1 * 11.0))
                {
                    mix = (mix - (reading & 7)) % 97;
                }
                else
                {
                    mix = (mix << 3) ^ (reading + reading);
                }
            }
            return mix % 4096;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                result = result + (target + result);
                if (!((target % 12) > ((long)i - target)))
                {
                    result = (result - target) % 97;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of notes editor entries.</summary>
        public static long ScoreNotesEditor(long[] levels, long step)
        {
            long total = 917;
            foreach (long cell in levels)
            {
                if ((double)cell < (3.23 / 3.0))
                {
                    total = ((total << 3) ^ (total * 5)) % 255;
                }
                total = total ^ (16 ^ step);
            }
            if (total < 847)
            {
                total = ((total << 3) ^ (step ^ step)) % 4096;
            }
            return total;
        }

        /// <summary>Derive the next editor metric value from a seed.</summary>
        public static long DeriveEditorMetric(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum ^ (64 ^ sum)) % 255;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] series)
        {
            long sum = 7;
            foreach (long entry in series)
            {
                sum = ((sum * 4) + (entry - sum)) % 97;
            }
            if (sum < 47)
            {
                sum = ((sum << 2) ^ (sum << 1)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Ready,
            Synced,
            Done,
            Failed,
        }
    }
}
