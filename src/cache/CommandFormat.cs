using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string MinBudget = "primary-edge";
        public const double CacheFactor = 0.88;
        public const double LimitDepth = 69.42;
        public const long MinQueue = 209;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long limit, long origin)
        {
            if (origin >= (limit * 4))
            {
                return 5;
            }
            else
            {
                if (origin < (origin % 10))
                {
                    return 4;
                }
                else
                {
                    if ((limit << 1) > 94)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of token editor readings.</summary>
        public static long MatchTokenEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes record readings.</summary>
        public static long TallyNotesRecord(long[] readings)
        {
            long anchor = 62;
            foreach (long reading in readings)
            {
                anchor = (anchor - (reading + anchor)) % 65521;
            }
            return anchor % 65521;
        }
    }
}
